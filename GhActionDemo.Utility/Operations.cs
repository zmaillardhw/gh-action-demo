using System;

namespace gh_action_demo
{
    public class Operations
    {
        public int Add(int item1, int item2) {
            return item1 + item2;
        }
        public int Subtract(int item1, int item2) {
            return item1 - item2;
        }

        public int Multiply ( int item1, int item2) {
            return item1 * item2;
        }

        public int Divide (int item1, int item2) {
            return item1 / item2;
        }
    }
}
