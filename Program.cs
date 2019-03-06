using System;
using CSPlot;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Synthetic
{
    class Program
    {
        public CSPlot.CSPlot csplot10 = new CSPlot.CSPlot();
        static void Main()
        {
            string json = @"{
               'CPU': 'Intel',
               'PSU': '500W',
               'Drives': [
                 'DVD read/writer'
                 /*(broken)*/,
                 '500 gigabyte hard drive',
                 '200 gigabyte hard drive'
               ]
            }";
            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            while (reader.Read()) {
                if (reader.HasLineInfo()) {
                    Console.Write(reader.Value);
                }
            }

        }
        void function0()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0;
            CSPlot.CSPlot.ReStart();
            csplot10.Open();
            csplot10.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function1()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
        }

        void function2()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function3()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function4()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function5()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function6()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function7()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function8()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function9()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function10()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function11()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function12()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function13()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function14()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function15()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function16()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();

        }

        void function17()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function18()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function19()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Show();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();

        }

        void function20()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function21()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function22()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function23()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function24()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function25()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function26()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function27()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function28()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function29()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function30()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function31()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function32()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function33()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function34()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function35()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function36()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function37()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function38()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Show();
            csplot1.Close();

        }

        void function39()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function40()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function41()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function42()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function43()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function44()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function45()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function46()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function47()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function48()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function49()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function50()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function51()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function52()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function53()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function54()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function55()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function56()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function57()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function58()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();

        }

        void function59()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function60()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function61()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function62()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot1.Show();
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Close();

        }

        void function63()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function64()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function65()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function66()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function67()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function68()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function69()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function70()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function71()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function72()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Show();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot1.Show();
            csplot1.Close();
            csplot0.Show();
            csplot1.Open();
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function73()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function74()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function75()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function76()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Plot(data);
            csplot0.Open();
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function77()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function78()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function79()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function80()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function81()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function82()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function83()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function84()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function85()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function86()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function87()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function88()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function89()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function90()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function91()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function92()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function93()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function94()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function95()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Show();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();

        }

        void function96()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function97()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function98()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function99()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function100()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();

        }

        void function101()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function102()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function103()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function104()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function105()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function106()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function107()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function108()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function109()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function110()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function111()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function112()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function113()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function114()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function115()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function116()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function117()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function118()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function119()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function120()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Show();
            csplot1.Close();
            csplot0.Close();

        }

        void function121()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function122()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function123()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function124()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function125()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function126()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function127()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function128()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function129()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function130()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function131()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function132()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function133()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function134()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function135()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function136()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Plot(data);
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function137()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function138()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function139()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function140()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function141()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function142()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function143()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function144()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function145()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function146()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function147()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();

        }

        void function148()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function149()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function150()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function151()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function152()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function153()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function154()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function155()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function156()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function157()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function158()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function159()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function160()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function161()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function162()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function163()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function164()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function165()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function166()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function167()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();

        }

        void function168()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function169()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function170()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot1.Open();
            csplot0.Show();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function171()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function172()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function173()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function174()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function175()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function176()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function177()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function178()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function179()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();

        }

        void function180()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot0.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot1.Plot(data);
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Close();

        }

        void function181()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function182()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function183()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function184()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function185()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function186()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function187()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function188()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function189()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Close();

        }

        void function190()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Show();
            csplot0.Close();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function191()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function192()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function193()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function194()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot0.Show();
            csplot1.Close();
            csplot1.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function195()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function196()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function197()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function198()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            csplot1.Close();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function199()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();

        }

        void function200()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function201()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function202()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function203()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function204()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function205()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function206()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function207()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function208()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function209()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function210()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function211()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function212()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function213()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();

        }

        void function214()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function215()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function216()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function217()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function218()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function219()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function220()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Close();

        }

        void function221()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function222()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function223()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function224()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function225()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function226()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function227()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function228()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function229()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function230()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function231()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function232()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function233()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function234()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function235()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function236()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Close();

        }

        void function237()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function238()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function239()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function240()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function241()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Show();
            csplot1.Close();
            csplot0.Close();

        }

        void function242()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function243()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Plot(data);
            csplot0.Show();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function244()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function245()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function246()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Show();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function247()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function248()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function249()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function250()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function251()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();

        }

        void function252()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function253()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Plot(data);
            csplot0.Open();
            csplot0.Plot(data);
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function254()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function255()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function256()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function257()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Plot(data);
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function258()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function259()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function260()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function261()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function262()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function263()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Show();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function264()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function265()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function266()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function267()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function268()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function269()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function270()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function271()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function272()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function273()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function274()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function275()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function276()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function277()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot0.Open();
            csplot0.Plot(data);
            csplot1.Close();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Show();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function278()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function279()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Show();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function280()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function281()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function282()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Show();
            csplot1.Plot(data);
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Close();

        }

        void function283()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function284()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function285()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function286()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function287()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function288()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function289()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function290()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function291()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function292()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function293()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function294()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function295()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function296()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();

        }

        void function297()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function298()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function299()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function300()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function301()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function302()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot1.Plot(data);
            csplot0.Show();
            csplot1.Close();
            csplot0.Close();

        }

        void function303()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function304()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function305()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function306()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function307()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function308()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function309()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Show();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function310()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function311()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function312()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function313()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function314()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function315()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function316()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function317()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Close();

        }

        void function318()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function319()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function320()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function321()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function322()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot0.Plot(data);
            csplot1.Close();
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function323()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function324()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function325()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Show();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function326()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function327()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot1.Open();
            csplot0.Show();
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function328()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function329()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function330()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Show();
            csplot1.Close();
            csplot0.Close();

        }

        void function331()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function332()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function333()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function334()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function335()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Plot(data);
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot0.Show();
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function336()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function337()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function338()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function339()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function340()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function341()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function342()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function343()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function344()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function345()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function346()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function347()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function348()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot0.Show();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function349()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function350()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Show();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function351()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot0.Show();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function352()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function353()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function354()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();

        }

        void function355()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function356()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Plot(data);
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();

        }

        void function357()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function358()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();

        }

        void function359()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function360()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Show();
            csplot1.Plot(data);
            csplot0.Plot(data);
            csplot1.Close();
            csplot0.Close();

        }

        void function361()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Show();
            csplot1.Close();

        }

        void function362()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function363()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function364()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function365()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Show();
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function366()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Plot(data);
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();

        }

        void function367()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function368()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Close();

        }

        void function369()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function370()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function371()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function372()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function373()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function374()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function375()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function376()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function377()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function378()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function379()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function380()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function381()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Show();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function382()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function383()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function384()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function385()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            csplot1.Close();
            csplot0.Close();

        }

        void function386()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function387()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function388()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function389()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function390()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();

        }

        void function391()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function392()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot1.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function393()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function394()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function395()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function396()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function397()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Show();
            csplot1.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function398()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function399()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function400()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function401()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function402()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function403()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function404()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function405()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function406()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function407()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function408()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function409()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Show();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function410()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function411()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function412()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function413()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function414()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function415()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function416()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function417()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot0.Open();
            csplot1.Plot(data);
            csplot0.Show();
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function418()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function419()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function420()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function421()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function422()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function423()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function424()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function425()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function426()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function427()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function428()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function429()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function430()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot0.Show();
            csplot1.Close();
            csplot0.Close();

        }

        void function431()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function432()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function433()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function434()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function435()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function436()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function437()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Show();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function438()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function439()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function440()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function441()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function442()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function443()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function444()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function445()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();

        }

        void function446()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function447()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function448()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function449()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function450()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function451()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function452()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function453()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function454()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function455()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Close();

        }

        void function456()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function457()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function458()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function459()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot1.Open();
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function460()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function461()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function462()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function463()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function464()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function465()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function466()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Close();

        }

        void function467()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function468()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function469()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function470()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Show();
            csplot1.Close();

        }

        void function471()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function472()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function473()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function474()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function475()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function476()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function477()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function478()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function479()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function480()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function481()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function482()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Plot(data);
            csplot0.Open();
            csplot1.Plot(data);
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function483()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function484()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function485()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function486()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function487()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Close();

        }

        void function488()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function489()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function490()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function491()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function492()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Show();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function493()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function494()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function495()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function496()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function497()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function498()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function499()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function500()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function501()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function502()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function503()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function504()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function505()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function506()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();

        }

        void function507()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function508()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function509()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Show();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function510()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function511()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function512()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function513()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function514()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function515()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function516()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function517()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function518()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function519()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function520()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Show();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function521()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function522()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function523()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function524()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function525()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function526()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function527()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function528()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot1.Open();
            csplot1.Close();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function529()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function530()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function531()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function532()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function533()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function534()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function535()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function536()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Plot(data);
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function537()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function538()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function539()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function540()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function541()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function542()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function543()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function544()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Show();
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function545()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function546()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function547()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function548()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function549()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function550()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function551()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function552()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function553()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function554()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function555()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function556()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function557()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function558()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function559()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function560()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function561()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function562()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function563()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function564()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Show();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function565()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function566()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function567()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function568()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Show();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function569()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function570()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function571()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function572()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function573()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function574()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function575()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function576()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();

        }

        void function577()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function578()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function579()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function580()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function581()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function582()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot1.Plot(data);
            csplot0.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function583()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function584()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function585()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function586()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function587()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function588()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function589()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function590()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function591()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function592()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function593()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Show();
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function594()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();

        }

        void function595()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot1.Show();
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function596()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function597()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();

        }

        void function598()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function599()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function600()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function601()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot1.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function602()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function603()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function604()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function605()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Close();

        }

        void function606()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function607()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function608()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function609()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function610()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function611()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function612()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function613()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function614()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function615()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function616()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Show();
            csplot1.Close();

        }

        void function617()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function618()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Show();
            csplot1.Close();

        }

        void function619()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function620()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function621()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function622()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function623()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function624()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function625()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function626()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function627()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function628()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot0.Open();
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function629()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function630()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function631()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function632()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function633()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function634()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function635()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function636()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function637()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function638()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function639()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function640()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function641()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function642()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function643()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function644()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function645()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function646()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function647()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot0.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function648()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function649()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot0.Close();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function650()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function651()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function652()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function653()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function654()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function655()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function656()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function657()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function658()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function659()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function660()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot0.Plot(data);
            csplot0.Show();
            csplot1.Close();
            csplot1.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Close();

        }

        void function661()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Show();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function662()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot1.Open();
            csplot0.Close();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function663()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function664()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function665()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function666()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function667()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function668()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function669()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function670()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function671()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function672()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function673()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function674()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function675()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Show();
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function676()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function677()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function678()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function679()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Show();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();

        }

        void function680()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function681()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function682()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function683()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function684()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function685()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function686()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function687()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function688()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function689()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function690()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function691()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function692()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function693()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Show();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function694()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot1.Close();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function695()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function696()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function697()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function698()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function699()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function700()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function701()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot1.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function702()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function703()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function704()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();

        }

        void function705()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function706()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function707()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot1.Open();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function708()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function709()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function710()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function711()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function712()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function713()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function714()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function715()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function716()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function717()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function718()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function719()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function720()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function721()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function722()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function723()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function724()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function725()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function726()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function727()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function728()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function729()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Close();

        }

        void function730()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function731()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function732()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function733()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function734()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function735()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Show();
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Plot(data);
            csplot0.Open();
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function736()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function737()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Show();
            csplot0.Open();
            csplot1.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Show();
            csplot0.Open();
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function738()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function739()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function740()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function741()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Plot(data);
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Show();
            csplot0.Plot(data);
            csplot1.Show();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function742()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function743()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function744()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function745()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Show();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Show();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();

        }

        void function746()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function747()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Show();
            csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot0.Show();
            csplot1.Plot(data);
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function748()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function749()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function750()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function751()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function752()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function753()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function754()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Close();

        }

        void function755()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function756()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function757()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function758()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Close();

        }

        void function759()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function760()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function761()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function762()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function763()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function764()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function765()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function766()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();

        }

        void function767()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Show();
            csplot1.Close();
            csplot0.Show();
            csplot0.Close();

        }

        void function768()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Show();
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function769()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function770()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function771()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function772()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function773()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function774()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function775()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function776()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function777()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();

        }

        void function778()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function779()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function780()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function781()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function782()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function783()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function784()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function785()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function786()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function787()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function788()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function789()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function790()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function791()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function792()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function793()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function794()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function795()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function796()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function797()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function798()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function799()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function800()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();

        }

        void function801()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function802()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function803()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function804()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function805()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function806()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function807()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function808()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function809()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function810()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function811()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function812()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function813()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function814()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function815()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function816()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function817()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function818()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function819()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function820()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function821()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function822()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function823()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function824()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function825()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function826()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Show();
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function827()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function828()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function829()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot1.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function830()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Close();

        }

        void function831()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot1.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function832()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function833()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function834()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function835()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function836()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function837()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Show();
            csplot1.Open();
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Close();

        }

        void function838()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function839()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function840()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Show();
            csplot0.Close();

        }

        void function841()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function842()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function843()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function844()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function845()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function846()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function847()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Show();
            csplot0.Close();

        }

        void function848()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function849()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function850()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function851()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function852()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function853()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function854()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot0.Open();
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function855()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function856()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function857()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function858()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function859()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function860()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function861()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function862()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot1.Close();
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function863()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function864()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function865()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function866()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function867()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function868()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function869()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function870()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot0.Close();

        }

        void function871()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function872()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function873()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function874()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function875()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function876()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function877()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function878()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function879()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function880()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot0.Show();
            csplot0.Close();
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function881()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function882()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot1.Open();
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function883()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function884()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function885()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function886()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function887()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function888()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Show();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function889()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function890()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Close();
            csplot0.Show();
            csplot0.Close();

        }

        void function891()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function892()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function893()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function894()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function895()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function896()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function897()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function898()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function899()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function900()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function901()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function902()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function903()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function904()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function905()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function906()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function907()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Close();

        }

        void function908()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function909()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function910()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function911()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();

        }

        void function912()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function913()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function914()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function915()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Show();
            csplot1.Close();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Plot(data);
            csplot0.Show();
            csplot1.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot1.Show();
            csplot1.Plot(data);
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function916()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Close();

        }

        void function917()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function918()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Close();

        }

        void function919()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function920()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function921()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Show();
            csplot1.Close();

        }

        void function922()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function923()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function924()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function925()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Show();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function926()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function927()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function928()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot0.Open();
            csplot1.Plot(data);
            csplot1.Show();
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function929()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Show();
            csplot0.Open();
            csplot0.Close();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Show();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();

        }

        void function930()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function931()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot0.Close();

        }

        void function932()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function933()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function934()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function935()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot0.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Show();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function936()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot0.Show();
            csplot1.Show();
            csplot0.Close();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function937()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function938()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function939()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();

        }

        void function940()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function941()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function942()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function943()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Show();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function944()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function945()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Show();
            csplot1.Show();
            csplot1.Close();
            csplot0.Close();

        }

        void function946()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function947()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function948()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function949()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function950()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function951()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot1.Plot(data);
            csplot0.Close();
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function952()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Show();
            csplot1.Plot(data);
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function953()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function954()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function955()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function956()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function957()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function958()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();

        }

        void function959()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function960()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function961()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Show();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();

        }

        void function962()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function963()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot1.AddLine(data);
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function964()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function965()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function966()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function967()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot0.Close();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function968()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function969()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function970()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Show();
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function971()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            if (!csplot1.IsEmpty()
           )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function972()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function973()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function974()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function975()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            } while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function976()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function977()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function978()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Show();
            csplot1.Show();
            csplot1.Close();
            csplot0.Close();

        }

        void function979()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function980()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            } while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot0.Plot(data);
            csplot0.Close();

        }

        void function981()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            if (!csplot0.IsEmpty()
           )
            {
                csplot0.Clean();
            }
            csplot0.Show();
            csplot0.Close();

        }

        void function982()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function983()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function984()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot1.Close();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function985()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot1.Open();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Plot(data);
            csplot1.Close();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();

        }

        void function986()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function987()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Close();

        }

        void function988()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function989()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot1.Open();
            csplot0.Open();
            csplot0.Close();
            csplot1.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function990()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            while (num_lines-- > 0)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function991()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function992()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function993()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot1.Open();
            csplot1.Close();

        }

        void function994()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();

        }

        void function995()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();
            csplot0.Open();
            csplot0.Plot(data);
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            csplot0.Close();

        }

        void function996()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Plot(data);
            csplot0.Show();
            csplot0.Close();

        }

        void function997()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Plot(data);
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot0.Close();

        }

        void function998()
        {
            var csplot0 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Show();
            csplot0.Close();

        }

        void function999()
        {
            var csplot0 = new CSPlot.CSPlot();
            var csplot1 = new CSPlot.CSPlot();
            List<int> data = new List<int>();
            int num_lines = 0; csplot0.Open();
            csplot0.Close();
            csplot0.Open();
            csplot1.Open();
            csplot1.Plot(data);
            csplot1.Close();
            if (!csplot0.IsEmpty()
            )
            {
                csplot0.Clean();
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            for (int i = 0; i < num_lines; i++)
            {
                csplot0.AddLine(data);
            }
            csplot0.Show();
            csplot1.Open();
            csplot0.Close();
            if (!csplot1.IsEmpty()
            )
            {
                csplot1.Clean();
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();
            csplot1.Open();
            while (num_lines-- > 0)
            {
                csplot1.AddLine(data);
            }
            csplot1.Close();
            csplot1.Open();
            csplot1.Close();

        }

    }
}
