using System;
using System.Text;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Session;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Internal;
using uPLibrary.Networking.M2Mqtt;
using System.Diagnostics;


namespace Mttq_Client1
{
    class Program
    {
        static void Main(string[] args)
        {
            MqttClient client = new MqttClient("mqtt.eclipse.org");
            byte code = client.Connect(Guid.NewGuid().ToString());
            


          ushort msgId = client.Subscribe(new string[] { "ev/odasicakligi" },
     new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
     client.MqttMsgPublishReceived += client_MqttMsgPublishReceived; 
                  


        }
        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) 
{ 
        Console.WriteLine("Topic :"+ e.Topic+" Gelen Mesaj :"+Encoding.UTF8.GetString(e.Message));
} 
    
    }
}
