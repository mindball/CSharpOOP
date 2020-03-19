using System;
using System.Collections.Generic;
using DotNetTutotialInterpretator.Contracts;
using DotNetTutotialInterpretator.Models;

namespace DotNetTutotialInterpretator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<AbstractExpression> expressions = new List<AbstractExpression>();
            Context context = new Context(DateTime.Now);
            Console.WriteLine("Please select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY ");

            context.Expression = Console.ReadLine();
            string[] strArray = context.Expression.Split(' ');

            foreach (var item in strArray)
            {
                if (item.Equals("DD"))
                    expressions.Add(new DayExpression());
                else if (item == "MM")
                    expressions.Add(new MonthExpression());
                else if (item == "YYYY")
                    expressions.Add(new YearExpression());
            }

            expressions.Add(new SeparatorExpression());
            foreach (var expression in expressions)
            {
                expression.Evaluate(context);
            }

            Console.WriteLine(context.Expression);
        }
    }
}
