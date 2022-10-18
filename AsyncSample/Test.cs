using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncSample {
    public class Test {
        public static async Task Process() {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            //var p1 = P1Async();
            //var p2 = P2Async();
            //var p3 = P3Async();
            //var AsyncTasks = new List<Task> { p1, p2, p3};
            //await Task.WhenAll(AsyncTasks);
            await Task.WhenAll(new List<Task>{P1Async(), P2Async(), P3Async()});
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
        private static async Task P1Async() {
            Console.WriteLine("p1: run.");
            await Task.Delay(3000);
            Console.WriteLine("p1: end.");
        }
        private static async Task P2Async() {
            Console.WriteLine("p2: run.");
            await Task.Delay(3000);
            Console.WriteLine("p2: end.");
        }
        private static async Task P3Async() {
            Console.WriteLine("p3: run.");
            await Task.Delay(3000);
            Console.WriteLine("p3: end.");
        }
    }
}
