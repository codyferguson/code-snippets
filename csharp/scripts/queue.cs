namespace scripts
{
    // Practice writing a simple queue. may add to it later for practice
    public class CustomQueue
    {
        private int add;
        private int remove;
        private int size;
        private string[] queueArray;

        public CustomQueue(int size) {
            add = 0;
            remove = 0;
            this.size = size;
            queueArray = new string[size];
        }

        public void Enqueue(string element) {
            if (queueArray.Length < length) {
                queueArray[add++] = element;
            } else {
                queueArray = copyArray();
            }
        }

        public string remove() {
            if (queueArray.Length != 0) {
                string item = queueArray[remove--];
                remove = remove >= size ? 0 : remove;
                return item;
            }
        }

        // Copies old array into array double it's size
        private string[] copyArray(string[] oldArray) {
            int oldSize = size;
            size = size << 1;
            string[] newArr = new string[size];
            for (int i = 0; i < oldSize; i++) {
                newArr[i] = queueArray.remove();
            }

            return newArr;
        }
    }
}