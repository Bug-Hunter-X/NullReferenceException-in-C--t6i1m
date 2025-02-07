public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Check if MyProperty is null before accessing it.
        if (MyProperty != null)
        {
            int value = MyProperty * 2; 
        }
        else
        {
            //Handle the case where MyProperty is null. For example:
            Console.WriteLine("MyProperty is null. Assigning a default value.");
            MyProperty = 0; //Or any other default value
            int value = MyProperty * 2;
        }
    }
} 