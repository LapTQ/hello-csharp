class Person
{
    private string m_name;

    public Person(string name)
    {
        m_name = name;
    }

    // getter and setter for m_name via property
    public string name {
        get { return m_name; }
        set { m_name = value; }
    }
}