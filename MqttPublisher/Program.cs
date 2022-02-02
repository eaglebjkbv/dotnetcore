using System;
using System.Text;
using System.Threading;
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
        static MqttClient client;
        static void Main(string[] args)
        {
            Console.WriteLine("Durdurmak için bir tuşa bsınız...");
            client = new MqttClient("mqtt.eclipse.org");
          

            // publish olduğunda çağırılacak method.Aşağıda
            client.MqttMsgPublished += client_MqttMsgPublished;

            byte code = client.Connect(Guid.NewGuid().ToString());
            ushort msgId = client.Publish("ev/odasicakligi",
           Encoding.UTF8.GetBytes("Yeni Mesaj 0"),
           MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
           false);
            Console.ReadKey(true);
            if(client.IsConnected){
                    client.Disconnect();

            }
        }
        static void client_MqttMsgPublished(object sender, MqttMsgPublishedEventArgs e)
        {
            Console.WriteLine("MessageId = " + (e.MessageId -1)+ " Published = " + e.IsPublished);
            ushort msgId = client.Publish("ev/odasicakligi",
           Encoding.UTF8.GetBytes("Yeni Mesaj"+ e.MessageId.ToString()),
           MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
           false);
        }
    }
}

