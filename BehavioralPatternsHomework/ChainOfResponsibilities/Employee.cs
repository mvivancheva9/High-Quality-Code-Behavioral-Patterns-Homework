namespace ChainOfResponsibilities
{
    abstract class Employee
    {
        protected Employee successor;

        public void SetSuccessor(Employee successor)
        {
            this.successor = successor;
        }

        public abstract void HandleDiscount(int discount);
    }
}