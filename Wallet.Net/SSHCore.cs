using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tamir.SharpSsh.jsch;
using System.Collections;

namespace Wallet.Net
{
    public class SSHCore
    {
        private string Password;
        private string Username;
        private string Host;
        private int Port;
        private int rPort;
        private int lPort;
        private string rHost;
        private JSch handler;
        private Session session;
        private SSHUserInfo UInfo;

        public SSHCore()
        {
            this.handler = new JSch();
            SSHUserInfo UI = new SSHUserInfo();
        }

        public void Connect(string User, string Password, string Host, int Port)
        {
            this.Host = Host;
            this.Username = User;
            this.Password = Password;
            this.Port = Port;
            this.session = this.handler.getSession(this.Username, this.Host, this.Port);
            this.session.setHost(this.Host);
            this.session.setPassword(this.Password);
            this.session.setUserInfo(this.UInfo);
            Hashtable config = new Hashtable();
            config.Add("StrictHostKeyChecking", "no");
            this.session.setConfig(config); 
            this.session.connect();
        }

        public void Tunnel(string remotehost, int remoteport, int localport)
        {
            this.rHost = remotehost;
            this.rPort = remoteport;
            this.lPort = localport;
            this.session.setPortForwardingL(this.lPort, this.rHost, this.rPort);
        }

        public void Disconnect()
        {
            this.session.disconnect();
        }

        public bool IsConnected()
        {
            return this.session.isConnected();
        }
    }

    public class SSHUserInfo : UserInfo
    {
        /// <summary>
        /// Holds the user password
        /// </summary>
        private String passwd;

        /// <summary>
        /// Returns the user password
        /// </summary>
        public String getPassword() { return passwd; }

        /// <summary>
        /// Prompt the user for a Yes/No input
        /// </summary>
        public bool promptYesNo(String str)
        {
            return true;
        }

        /// <summary>
        /// Returns the user passphrase (passwd for the private key file)
        /// </summary>
        public String getPassphrase() { return null; }

        /// <summary>
        /// Prompt the user for a passphrase (passwd for the private key file)
        /// </summary>
        public bool promptPassphrase(String message) { return true; }

        /// <summary>
        /// Prompt the user for a password
        /// </summary>
        public bool promptPassword(String message) { return true; }

        /// <summary>
        /// Shows a message to the user
        /// </summary>
        public void showMessage(String message) { }
    }
}
