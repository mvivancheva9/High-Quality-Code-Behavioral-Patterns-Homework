using System.Collections;

namespace IteratorPattern
{
    internal class ConcreteAggregate : Aggregate
    {
        private ArrayList items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Property 
        public int Count
        {
            get { return items.Count; }
        }

        // Indexer 
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}