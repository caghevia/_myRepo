


List<Person> people = Example.Example2;

var byteArray = CsvGenerator.CsvGenerator.GenerateCsv2(people);
CsvGenerator.CsvGenerator.WriteCsvFromBytes(byteArray, "path_to_save.csv");

