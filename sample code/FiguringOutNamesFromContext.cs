internal class C
{
    private void SaveDocument()
    {
        DatabaseConnection c = GetDatabaseConnection();
        Applesauce(c); // SaveDocumentToDatabase
    }

    private void SaveDocument()
    {
        if (useDatabase)
        {
            ApplesauceA(); // SaveDocumentToDatabase
        }
        else if (useFileSystem)
        {
            ApplesauceB(); // SaveDocumentToFile
        }
    }

    private void CalculateTheMeanOfTheDerivatives(Function function1, Function function2)
    {
        var derivative1 = GetDerivative(function1);
        var derivative2 = GetDerivative(function2);
        return Applesauce(derivative1, derivative2);
    }

    private void CalculateTheMeanOfTheDerivatives(Function function1, Function function2)
    {
        var applesauce1 = Applesauce(function1);
        var applesauce2 = Applesauce(function2);
        return CalculateTheMean(applesauce1, applesauce2);
    }
}