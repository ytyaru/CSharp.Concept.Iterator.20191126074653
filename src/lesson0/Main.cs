using System;

namespace Concept.Iterator.Lesson0 {
    class Main {
        public void Run() {
            foreach (var item in new int[] { 1,3,5 }) {
                Console.WriteLine($"{item}");
            }
        }
    }
}
