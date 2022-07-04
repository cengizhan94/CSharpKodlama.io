using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[]logics)
        {
            foreach (var logic in logics) //logic -> iş kuralı
            {
                if (!logic.Success) //Hangi kuralda sorun varsa o kuralın kendisini döndüren method
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
