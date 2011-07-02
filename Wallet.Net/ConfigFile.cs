using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace Wallet.Net
{
    public class ConfigFile
    {
        public string BitCoinHost;
        public string BitCoinPort;
        public string BitCoinUser;
        public string BitCoinPass;
        public bool UseSSH;
        public string SSHUser;
        public string SSHPass;
        public bool IsNew;

        public void Read()
        {
            string filename = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName) + "\\walletconfig.xml";
            if (File.Exists(filename))
            {
                ConfigFile temp = ConfigFile.Load(filename);
                this.BitCoinHost = temp.BitCoinHost;
                this.BitCoinPort = temp.BitCoinPort;
                this.BitCoinUser = temp.BitCoinUser;
                this.BitCoinPass = temp.BitCoinPass;
                this.UseSSH = temp.UseSSH;
                this.SSHUser = temp.SSHUser;
                this.SSHPass = temp.SSHPass;
                this.IsNew = false;
            }
            else
            {
                this.IsNew = true;
            }
        }

        public void Write()
        {
            string filename = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName) + "\\walletconfig.xml";
            ConfigFile.Save(filename, this);
        }

        static ConfigFile Load(string filename)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(ConfigFile));
            TextReader reader = new StreamReader(filename);
            ConfigFile Temp = (ConfigFile)deserializer.Deserialize(reader);
            reader.Close();
            return Temp;
        }

        static void Save(string filename, ConfigFile CF)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ConfigFile));
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, CF);
            writer.Close();
        }
    }
}
