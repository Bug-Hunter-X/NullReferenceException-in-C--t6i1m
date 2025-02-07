public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        //This will throw a NullReferenceException if MyProperty is not initialized before this line.
        int value = MyProperty * 2; 
    }
}