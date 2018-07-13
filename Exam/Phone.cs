using Exam.entity;

namespace Exam
{
    public class Phone : Product
    {
        public override double computeTax()
        {
            return Price * 10 / 100;
        }
    }
}