using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barsGroupTaskEvents
{
    public class InputStopper
    {
        public event EventHandler<char> OnKeyPressed;

        public void Run()
        {
            bool trg;

            trg = true;
            while (trg)
            {
                Console.WriteLine("Press any key: ");
                var input = Console.ReadKey();

                switch (input.KeyChar)
                {
                    case 'c':
                        trg = false;
                        break;
                    default:
                        OnKeyPressed?.Invoke(this, input.KeyChar);
                        break;
                }
            }
        }

       public void Print(Object sender, char key)
       {
            Console.WriteLine($"\nKey: {key}\n");
       }
    }
}
