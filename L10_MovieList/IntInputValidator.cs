using System;

///-----------------------------------------------------------------------------
///   Namespace:    L10_MovieList
///   Description:  Input a number from a list of genres to get the movies that
///                 match that genre.
///   Author:       Derek Wolters                
///   Date:         4.10.17
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------------------

namespace L10_MovieList
{
    class IntInputValidator
    {        
        public static int ValidateInput()
        {
            int result;
            
            bool isValid = int.TryParse(Console.ReadLine(), out result);

            if (isValid)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
                return ValidateInput();
            }
        }
        
    }
}
