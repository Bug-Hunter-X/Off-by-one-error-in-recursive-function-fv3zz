public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0) {
            return b; //Should be return 1; 
        }
        return a + b; 
    }
}