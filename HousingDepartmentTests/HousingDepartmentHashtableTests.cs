using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP2.src;
using OOP2.src.exception;
using OOP2.Src.Subject;

[TestClass]
public class HousingDepartmentHashtableTests
{
    private HousingDepartmentHashtable _hashtable;

    [TestInitialize]
    public void Setup()
    {
        _hashtable = new HousingDepartmentHashtable();
    }

    [TestMethod]
    public void AddRandomByKeyTest()
    {
        int key = 10;

        _hashtable.AddRandomByKey(key);

        Assert.IsTrue(_hashtable.Contains(key));
    }

    [TestMethod]
    public void RemoveTest()
    {
        int key = 15;

        _hashtable.AddRandomByKey(key);
        _hashtable.Remove(key);

        Assert.IsFalse(_hashtable.Contains(key));
    }

    [TestMethod]
    public void GetByKeyTest()
    {
        int key = 20;

        _hashtable.AddRandomByKey(key);

        var result = _hashtable.Get(key);

        Assert.IsNotNull(result);
        Assert.AreEqual(key, result.HousingDepartmentNumber);
    }

    [TestMethod]
    public void CountIncreaseAfterAddTest()
    {
        int before = _hashtable.Count;

        _hashtable.AddRandomByKey(1);
        _hashtable.AddRandomByKey(2);

        Assert.AreEqual(before + 2, _hashtable.Count);
    }

    [TestMethod]
    [ExpectedException(typeof(KeyAlreadyExistsException))]
    public void AddDuplicateKeyExceptionTest()
    {
        int key = 5;

        _hashtable.AddRandomByKey(key);
        _hashtable.AddRandomByKey(key);
    }

    [TestMethod]
    [ExpectedException(typeof(KeyDoesNotExistException))]
    public void RemoveNonExistingKeyExceptionTest()
    {
        _hashtable.Remove(999);
    }
}
