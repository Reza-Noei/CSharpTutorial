using System;
using System.IO;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace TutorialNoei
{
    internal class TryCatch
    {
        public TryCatch()
        {
            try
            {
                // exception may get thrown within execution of this block
                // throw new Exception("Message");
                object obj = null; 

                ArgumentNullException.ThrowIfNull(obj, "Parameter");
            }
            catch (ArgumentNullException ex)
            {
                // handle exception of type ExceptionA
                // throw new MammadException(title: "Argument Exception");
                throw ex;
            }
            catch (ArgumentException ex)
            {
                var message = ex.Message;
            }
            catch (DivideByZeroException ex)
            {
                // handle exception of type ExceptionB
                throw;
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout)
            {
                // 
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.SendFailure)
            {
                // 
            }
            catch (Exception ex)
            {
                // return internal exception error.
            }
            finally
            {
                // cleanup code

                var aa = new string("RezA");
            }

            // Catching System.Exception catches all possible errors.This is useful in the following circumstances:
            //      1. Your program can potentially recover regardless of the specific exception type.
            //      2. You plan to rethrow the exception (perhaps after logging it).
            //      3. Your error handler is the last resort, prior to termination of the program.

            // A finally block executes after any of the following:
            //      1. A catch block finishes(or throws a new exception)
            //      2. The try block finishes(or throws an exception for which there’s no catch block) 
            //      3. Control leaves the try block because of a jump statement(e.g., return or goto)

            // The only things that can defeat a finally block are an infinite loop or the process ending abruptly.

            bool a = 1 == 1 ? throw new ArgumentException("value") : false;

            if (1 == 1)
            {
                throw new ArgumentException("Value");
            }
            else
            {
                a = false;
            }
        }

        // Expression Bodied
        public string Foo(int a) => "sadsadasdas";
        
        public DateTime BirthDay { get; set; }    
        
        public int Age => (DateTime.Now - BirthDay).Days / 365;        
    }
}
