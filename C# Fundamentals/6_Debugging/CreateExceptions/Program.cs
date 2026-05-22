//Creating an Exception Object
ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");
throw invalidArgumentException;

//Can also create the object within the throw statement
throw new FormatException("FormatException: Calculations in process XYZ have been cancelled due to invalid data format.");

//Or re-throw an exception from inside a catch block
catch (Exception ex)
{
    // handle or partially handle the exception
    // ...

    // re-throw the original exception object for further handling down the call stack
    throw;
}
