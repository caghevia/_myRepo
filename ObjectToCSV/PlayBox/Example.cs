public static class Example
{
    public static List<Person> Example1 = new List<Person>
        {
            new Person
            {
                Name = "John",
                Age = 30,
                Hobbies = new List<Hobby>
                {
                    new Hobby { HobbyName = "Reading", Details =  "Fiction"  },
                    new Hobby { HobbyName = "Swimming", Details = "Pool" }
                }
            },
            new Person
            {
                Name = "Doe",
                Age = 25,
                Hobbies = new List<Hobby>
                {
                    new Hobby { HobbyName = "Hiking", Details = "Mountains"}
                }
            }
        };

    public static List<Person> Example2 = new List<Person>
        {
            new Person
            {
                Name = "John",
                Age = 30,
                Hobbies = new List<Hobby>
                {
                    new Hobby { HobbyName = "Reading", Details =  "Fiction", Category = new List<Category>{
                        new Category {
                            CatName = "catName1",
                            Other="OtherCat1" } }  },
                    new Hobby { HobbyName = "Swimming", Details = "Pool" }
                },
                Category = new(){ CatName = "catName0",
                            Other="OtherCat0"}
            },
            new Person
            {
                Name = "Doe",
                Age = 25,
                Hobbies = new List<Hobby>
                {
                    new Hobby { HobbyName = "Hiking", Details = "Mountains"}
                }
            },
             new Person
            {
                Name = "Pedro",
                Age = 46,
                Hobbies = new List<Hobby>
                {
                    new Hobby { HobbyName = "Hobb2", Details = "HobDeta2", Category = new List<Category>{
                        new Category {
                            CatName = "catName2",
                            Other="OtherCat2" },
                        new Category {
                            CatName = "catName3",
                            Other="OtherCat3" } }  ,}
                }
            }
        };
}