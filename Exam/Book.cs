using Exam.entity;

namespace Exam
{
    public class Book : Product
    {
        public override double computeTax()
        {
            return Price * 5 / 100;
        }
    }
}