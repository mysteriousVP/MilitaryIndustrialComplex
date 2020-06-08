namespace MilitaryIndustrialComplexSolution
{
    public abstract class Receiver
    {
        protected Mediator mediator;

        public Receiver(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual bool Send(string message)
        {
            return mediator.SendEmail(message, this);
        }
        public abstract void Notify(string message);
    }
}