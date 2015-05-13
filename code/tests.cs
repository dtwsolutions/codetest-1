using System;

static class Tests {
    public static void HelloWorldTest() {
        Assert.AreEqual("Hello World!", Code.HelloWorld());
    }
    public static void CapitalizeEveryNthWordTest() {
        var sentence = "Lorem ipsum dolor sit amet";
        Assert.AreEqual("Lorem ipsum Dolor sit Amet", Code.CapitalizeEveryNthWord(sentence, 0, 2));
        Assert.AreEqual("Lorem ipsum Dolor Sit Amet", Code.CapitalizeEveryNthWord(sentence, 2, 1));
    }
    public static void IsPrimeTest() {
        Assert.IsFalse(Code.IsPrime(-1), "IsPrime(-1) should be false.");
        Assert.IsFalse(Code.IsPrime(0), "IsPrime(0) should be false.");
        Assert.IsFalse(Code.IsPrime(1), "IsPrime(1) should be false.");
        Assert.IsTrue(Code.IsPrime(2), "IsPrime(2) should be true.");
        Assert.IsTrue(Code.IsPrime(5), "IsPrime(5) should be true.");
        Assert.IsFalse(Code.IsPrime(87), "IsPrime(87) should be false.");
        Assert.IsTrue(Code.IsPrime(97), "IsPrime(97) should be true.");
    }
    public static void GoldenRatioTest() {
        Assert.IsInRange(1.61800, 1.61806, Code.GoldenRatio(1.0, 1.0));
        Assert.IsInRange(1.61800, 1.61806, Code.GoldenRatio(100, 6));
    }
}