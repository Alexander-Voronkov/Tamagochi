using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace Tamagochi
{
    public interface IRequest
    {
        string Request();
        string Caption();
    }

    public class FeedRequest : IRequest
    {
        public string Request() { return "Can you feed me?"; }
        public string Caption() { return "I want to eat..."; }
    }

    public class PlayRequest : IRequest
    {
        public string Request() { return "I'd like to play!"; }
        public string Caption() { return "Will you play with me?"; }
    }

    public class PutToSleepRequest : IRequest
    {
        public string Request() { return "I want to sleep!"; }
        public string Caption () { return "Could you tell me a story?"; }
    }

    public class TreatRequest : IRequest
    {
        public string Request() { return "Khe-khe, i'm sick..."; }
        public string Caption() { return "Treat me please"; }
    }
    public class WalkRequest : IRequest
    {
        public string Request() { return "I want to go for a walk!"; }
        public string Caption() { return "Таke me for a walk!"; }
    }

    public enum Condition
    {
        Healthy, Sick, Dead
    }
    public class Tamagochi
    {
        public int NonRealisedCount = default(int);
        public Condition Condition=Condition.Healthy;
        public void Display()
        {
            Console.Clear();
            switch (Condition)
            {
                case Condition.Healthy:PrintHealthy();
                    break;
                case Condition.Sick:PrintSick();
                    break;
                case Condition.Dead:PrintDead();
                    break;
            }
        }
        private void PrintSick()
        {
            string[] arr = {
                           "@@@@@@@@@@@@@@@@@@&#BGP555PPGB#&@@@@@@@@@@@@@@@@@@",
                           "@@@@@@@@@@@@@&B5?!^:::::.:::::^~7JPB&@@@@@@@@@@@@@",
                           "@@@@@@@@@@#57^...........:::::::::::~?P&@@@@@@@@@@",
                           "@@@@@@@@B7:................::::::::::::~JB@@@@@@@@",
                           "@@@@@@B7...................::::::::::::::^?#@@@@@@",
                           "@@@@@J..........$$$$.......:::$$$$:::::::::^5@@@@@",
                           "@@@&7..........$$$$$$......::$$$$$$::::::::::?@@@@",
                           "@@&!..........:$$$$$$......::$$$$$$:::::::::::?@@@",
                           "@@J...........:$$$$$$.....:::$$$$$$::::::::::::Y@@",
                           "@B:............$$$$$$....::::$$$$$$::::::::::::^#@",
                           "@Y.:............$$$$...::::::::$$$$:::::::::::::5@",
                           "@7.::................:::::::::::::::::::::::::::?@",
                           "@?::::...........:::::::::::::::::::::::::::::::?@",
                           "@Y::::::::::::::::::$$$$$$$$$:::::::::::::::::::5@",
                           "@#^::::::::::::::$$$$$$$$$$$$$$$:::::::::::::::^#@",
                           "@@Y:::::::::::::$$$:::::::::::$$$::::::::::::::Y@@",
                           "@@@?:::::::::::$$$:::::::::::::$$$::::::::::::?@@@",
                           "@@@@?:::::::::$$::::::::::::::::$$$::::::::::?@@@@",
                           "@@@@@5^::::::$$$:::::::::::::::::$$$:::::::^5@@@@@",
                           "@@@@@@#?^::::::::::::::::::::::::::::::::^?#@@@@@@",
                           "@@@@@@@@#J~::::::::::::::::::::::::::::~J#@@@@@@@@",
                           "@@@@@@@@@@&P?~::::::::::::::::::::::~?P&@@@@@@@@@@",
                           "@@@@@@@@@@@@@&BPJ7~^^::::::::^^~7JPB&@@@@@@@@@@@@@",
                           "@@@@@@@@@@@@@@@@@@&#BGGPPPPGGB#&@@@@@@@@@@@@@@@@@@"
                };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        private void PrintHealthy()
        {
            string[] arr = {
                           "@@@@@@@@@@@@@@@@@@&#BGP555PPGB#&@@@@@@@@@@@@@@@@@@",
                           "@@@@@@@@@@@@@&B5?!^:::::.:::::^~7JPB&@@@@@@@@@@@@@",
                           "@@@@@@@@@@#57^...........:::::::::::~?P&@@@@@@@@@@",
                           "@@@@@@@@B7:................::::::::::::~JB@@@@@@@@",
                           "@@@@@@B7...................::::::::::::::^?#@@@@@@",
                           "@@@@@J..........:!!:.......::::!7^:::::::::^5@@@@@",
                           "@@@&7..........?&@@B~......::~#@@&?::::::::::?@@@@",
                           "@@&!..........:&@@@@G......::G@@@@&^::::::::::?@@@",
                           "@@J...........:&@@@@G.....:::G@@@@&^:::::::::::Y@@",
                           "@B:............?&@@B~....::::~#@@&?::::::::::::^#@",
                           "@Y.:............^!!:...::::::::!7^::::::::::::::5@",
                           "@7.::................:::::::::::::::::::::::::::?@",
                           "@?::::...........:::::::::::::::::::::::::::::::?@",
                           "@Y:::::::::^7::::::::::::::::::::::::7~:::::::::5@",
                           "@#^:::::^^?Y^::::::::::::::::::::::::^Y?~^:::::^#@",
                           "@@Y::::~!~?B7::::::::::::::::::::::::7B?!!~::::Y@@",
                           "@@@?:::::::~GP!::::::::::::::::::::!PG~:::::::?@@@",
                           "@@@@?::::::::?GGJ!::::::::::::::!JGG?::::::::?@@@@",
                           "@@@@@5^::::::::!YGGP5J?7!!7?J5PBGY!::::::::^5@@@@@",
                           "@@@@@@#?^:::::::::^!?Y5PPPP5Y?!^:::::::::^?#@@@@@@",
                           "@@@@@@@@#J~::::::::::::::::::::::::::::~J#@@@@@@@@",
                           "@@@@@@@@@@&P?~::::::::::::::::::::::~?P&@@@@@@@@@@",
                           "@@@@@@@@@@@@@&BPJ7~^^::::::::^^~7JPB&@@@@@@@@@@@@@",
                           "@@@@@@@@@@@@@@@@@@&#BGGPPPPGGB#&@@@@@@@@@@@@@@@@@@"
                };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
           
        }
        private void PrintDead()
        {
             string[] arr = {
                           "@@@@@@@@@@@@@@@@@@&#BGP555PPGB#&@@@@@@@@@@@@@@@@@@",
                           "@@@@@@@@@@@@@&B5?!^:::::.:::::^~7JPB&@@@@@@@@@@@@@",
                           "@@@@@@@@@@#57^...........:::::::::::~?P&@@@@@@@@@@",
                           "@@@@@@@@B7:................::::::::::::~JB@@@@@@@@",
                           "@@@@@@B7...................::::::::::::::^?#@@@@@@",
                           "@@@@@J........$$$...$$$....:$$$...$$$::::::^5@@@@@",
                           "@@@&7.........$$$..$$$.....:$$$..$$$:::::::::?@@@@",
                           "@@&!..........:.$$$$$.........$$$$$.::::::::::?@@@",
                           "@@J...........:.$$$$......:::.$$$$..:::::::::::Y@@",
                           "@B:............$$$$$$....::::$$$$$$::::::::::::^#@",
                           "@Y.:..........$$$..$$$.:::::$$$..$$$::::::::::::5@",
                           "@7.::................:::::::::::::::::::::::::::?@",
                           "@?::::...........:::::::::::::::::::::::::::::::?@",
                           "@Y::::::::::::::::::::::::::::::::::::::::::::::5@",
                           "@#^::::::::::::::::::::::::::::::::::::::::::::^#@",
                           "@@Y::::~!:::::::::::::::::::::::::::::::!!~::::Y@@",
                           "@@@?::::::::::!:::::::::::::::::::::::::::::::?@@@",
                           "@@@@?:::::::::$$$$$$$$$$$$$$$$$$$$$$:::::::::?@@@@",
                           "@@@@@5^:::::::$$$$$$$$$$$$$$$$$$$$$$:::::::^5@@@@@",
                           "@@@@@@#?^::::::::::::::::::::::^:::::::::^?#@@@@@@",
                           "@@@@@@@@#J~::::::::::::::::::::::::::::~J#@@@@@@@@",
                           "@@@@@@@@@@&P?~::::::::::::::::::::::~?P&@@@@@@@@@@",
                           "@@@@@@@@@@@@@&BPJ7~^^::::::::^^~7JPB&@@@@@@@@@@@@@",
                           "@@@@@@@@@@@@@@@@@@&#BGGPPPPGGB#&@@@@@@@@@@@@@@@@@@"
                };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class App
    {
        private Tamagochi Tam=new Tamagochi();
        private Stack<IRequest> PrevRequests = new Stack<IRequest>();
        private IRequest[] Requests = new IRequest[5];
        public App()
        {
            Requests[0] = new FeedRequest();
            Requests[1] = new WalkRequest();
            Requests[2] = new PlayRequest();
            Requests[3] = new TreatRequest();
            Requests[4] = new PutToSleepRequest();
        }
        public void Start()
        {
            using (System.Timers.Timer t = new System.Timers.Timer())
            {
                t.Interval = 1000;
                int time = 0;
                t.Start();
                t.Elapsed += ((object sender, System.Timers.ElapsedEventArgs e) => time++);
                int limit = new Random().Next(100, 150);
                while (time!=limit&&Tam.Condition!=Condition.Dead)
                {
                    Tam.Display();
                    if (Tam.NonRealisedCount != 3)
                    {
                        int q= new Random().Next(0, 4);
                        if (PrevRequests.Count != 0)
                        {
                            do
                            {
                                q = new Random().Next(0, 4);

                            } while (Requests[q].Caption() == PrevRequests.Peek().Caption());
                        }
                        IRequest temp;
                        switch (q)
                        {
                            case 0: temp = Requests[0]; break;
                            case 1: temp = Requests[1]; break;
                            case 2: temp = Requests[2]; break;
                            case 3: temp = Requests[3];Tam.Condition = Condition.Sick; break;
                            default: temp = Requests[4]; break;
                        }
                        DialogResult a=MessageBox.Show(temp.Request(), temp.Caption(), MessageBoxButtons.YesNo);
                        switch (a)
                        {
                            case DialogResult.Yes:
                                Tam.Condition = Condition.Healthy;
                                Tam.NonRealisedCount = 0;
                                break;
                            case DialogResult.No:
                                Tam.NonRealisedCount++;
                                break;
                        }
                        PrevRequests.Push(temp);
                    }
                    else
                    {
                        IRequest temp=Requests[3];
                        DialogResult a=MessageBox.Show(temp.Request(), temp.Caption(), MessageBoxButtons.YesNo);
                        switch(a)
                        {
                            case DialogResult.Yes:Tam.NonRealisedCount = 0;Tam.Condition = Condition.Healthy; break;
                            case DialogResult.No:Tam.Condition = Condition.Dead;break;
                        }
                    }
                }
                Console.Clear();
                Tam.Display();
                Console.SetCursorPosition(70,10);
                Console.WriteLine($"Ваш Тамагочи жил {time} секунд");
               
            }
        }
    }
    
    internal class Program
    {        
        static void Main(string[] args)
        {
            App app=new App();
            app.Start();
            Console.Read();
        }
    }
}
