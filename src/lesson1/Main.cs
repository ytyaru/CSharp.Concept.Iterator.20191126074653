using System; // Console
using System.Collections.Generic; // IEnumerable

namespace Concept.Iterator.Lesson1 {
    class Main {
        public void Run() {
            foreach (var item in ReturnYield()) {
                Console.WriteLine($"{item}");
            }
        }
        private IEnumerable<int> ReturnYield() {
            yield return 1;
            yield return 3;
            yield return 5;
        }
    }
}
