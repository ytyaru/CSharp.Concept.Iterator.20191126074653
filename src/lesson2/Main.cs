using System; // Console
using System.Collections.Generic; // IEnumerable

namespace Concept.Iterator.Lesson2 {
    class Main {
        public void Run() {
            foreach (var item in ReturnYield()) {
                Console.WriteLine($"{item}");
            }
        }
        private IEnumerable<int> ReturnYield() {
            for (int i=0; i<6; i++) {
                if (1 == (i%2)) { yield return i; }
            }
        }
    }
}
