using System.Text.Json;

// deserialize mario json from file into List<Mario>
List<Character> dks = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("dk.json"))!;
// deserialize mario json from file into List<Mario>
List<Character> marios = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("mario.json"))!;
// combine all characters into 1 list
List<Character> characters = [];
characters.AddRange(dks);
characters.AddRange(marios);

// display all characters
// foreach(Character character in characters)
// {
//   Console.WriteLine(character.Display());
// }
Console.Clear();

// display first character
// Console.WriteLine(characters.First().Display());

// display the first 5 characters
// foreach(Character character in characters.Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display every character except the first 5
// foreach(Character character in characters.Skip(5))
// {
//   Console.WriteLine(character.Display());
// }

// display characters 6-10
// foreach(Character character in characters.Skip(5).Take(5))
// {
//   Console.WriteLine(character.Display());
// }

// display last character
// Console.WriteLine(characters.Last().Display());

// first year character created
// Console.WriteLine(characters.Min(c => c.YearCreated));

// oldest character
// Console.WriteLine(characters.First(c => c.YearCreated == characters.Min(c => c.YearCreated)).Display());

// are there any characters created in 1995?
// bool Character1995 = characters.Any(c => c.YearCreated == 1995);
// Console.WriteLine($"Are there characters created in 1995: {Character1995}");
// how many characters were created in 1995
// Console.WriteLine($"How many? {characters.Count(c => c.YearCreated == 1995)}");
// which characters were created in 1995
// foreach(CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1995).Select(c => new CharacterDTO{ Id = c.Id, Name = c.Name, Series = c.Series }).OrderBy(c => c.Name))
// {
//   Console.WriteLine(characterDTO.Display());
// }

// how many characters in total (all series)?
// int CharacterCount = characters.Count();
// Console.WriteLine($"There are {CharacterCount} characters in all series");
// how many characters appear in the Mario series?
// int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {MarioCount} characters in the Mario series");
// how many characters appear in the Donkey Kong series?
// int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
// Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");
// how many characters appear in the Mario & Donkey Kong series?
// int DkMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkMarioCount} characters that appear in Mario and Donkey Kong series");
// which characters (name only) appear in Mario and Donkey Kong?
// foreach(String? name in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }
// how many characters appear in Donkey Kong and not in Mario?
// int DkNotMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && !c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkNotMarioCount} characters that appear in Donkey Kong and Not in Mario series");

// which character(s) has/have the most alias's?
// foreach(var obj in characters.Where(c => c.Alias.Count() == characters.Max(c => c.Alias.Count())).Select(c => new {c.Name, c.Alias})){
//   Console.WriteLine($"{obj.Name} has {obj.Alias.Count()} alias(s):\n\t{String.Join(", ", obj.Alias)}");
// }

// how many letters make up the longest character name(s)
// int LengthOfName = characters.Max(c => c.Name!.Length);
// Console.WriteLine($"There are {characters.Max(c => c.Name!.Length)} letters in the longest character's name");
// which characters have the longest name?
// foreach(string? name in characters.Where(c => c.Name!.Length == LengthOfName).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }

// all characters grouped by year created
// var CharactersByYearCreated = characters.GroupBy(c => c.YearCreated);
// foreach(var characterByYearCreated in CharactersByYearCreated)
// {
//   Console.WriteLine(characterByYearCreated.Key);
//   foreach(var character in characterByYearCreated) {
//     Console.WriteLine($"\t{character.Name}");
//   }
// }
// How many characters were created in 1981? (all series)
// int characters1981 = characters.Count(c => c.YearCreated == 1981);
// Console.WriteLine($"There are {characters1981} characters created in 1981");
// // List the characters created in 1981 (all series) - return the name and series only
// foreach(CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1981).Select(c => new CharacterDTO{ Name = c.Name, Series = c.Series }))
// {
//   Console.WriteLine($"{characterDTO.Name} - {string.Join(", ", characterDTO.Series)}");
// }
// how many characters were created in 1981 in the Mario series?
// int characters1981Mario = characters.Count(c => c.YearCreated == 1981 && c.Series.Contains("Mario"));
// Console.WriteLine($"There are {characters1981Mario} characters created in 1981 in the Mario series");
// List the characters created in 1981 in the Mario series - return the name only
// foreach(string? name in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }
// how many characters were created in 1981 in the Donkey Kong series?
// int characters1981Dk = characters.Count(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong"));
// Console.WriteLine($"There are {characters1981Dk} characters created in 1981 in the Donkey Kong series");
// List the characters created in 1981 in the Donkey Kong series - return the name only
// foreach(string? name in characters.Where(c => c.YearCreated == 1981 && c.Series.Contains("Donkey Kong")).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }
//how many characters made their first appearance in Donkey Kong 64?
// int charactersAppearedDK64 = characters.Count(c => c.FirstAppearance.Contains("Donkey Kong 64"));
// Console.WriteLine($"There are {charactersAppearedDK64} characters that appeared in Donkey Kong 64");
// List the characters that made their first appearance in Donkey Kong 64 - return the name only
// foreach(string? name in characters.Where(c => c.FirstAppearance.Contains("Donkey Kong 64")).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }
// are there any characters that have no alias (all series)?
// bool noAlias = characters.Any(c => c.Alias.Count() == 0);
// Console.WriteLine($"Are there characters with no alias: {noAlias}");
// how many characters have no alias (all series)?
// int noAliasCount = characters.Count(c => c.Alias.Count() == 0);
// Console.WriteLine($"There are {noAliasCount} characters with no alias");
// List the characters that have no alias (all series) - return the name, alias and series only
// foreach(CharacterDTO characterDTO in characters.Where(c => c.Alias.Count() == 0).Select(c => new CharacterDTO{ Name = c.Name, Alias = c.Alias, Series = c.Series }))
// {
//   Console.WriteLine($"{characterDTO.Name} - {string.Join(", ", characterDTO.Alias)} - {string.Join(", ", characterDTO.Series)}");
// }
// Are there any characters that have no alias in the Mario series?
// bool noAliasMario = characters.Any(c => c.Series.Contains("Mario") && c.Alias.Count() == 0);
// Console.WriteLine($"Are there characters with no alias in the Mario series: {noAliasMario}");
// how many characters have no alias in the Mario series?
// int noAliasCountMario = characters.Count(c => c.Series.Contains("Mario") && c.Alias.Count() == 0);
// Console.WriteLine($"There are {noAliasCountMario} characters with no alias in the Mario series");
// List the characters that have no alias in the Mario series - return the name and alias only
// foreach(CharacterDTO characterDTO in characters.Where(c => c.Series.Contains("Mario") && c.Alias.Count() == 0).Select(c => new CharacterDTO{ Name = c.Name, Alias = c.Alias }))
// {
//   Console.WriteLine($"{characterDTO.Name} - {string.Join(", ", characterDTO.Alias)}");
// }
// Are there any characters that have no alias in the Donkey Kong series?
// bool noAliasDk = characters.Any(c => c.Series.Contains("Donkey Kong") && c.Alias.Count() == 0);
// Console.WriteLine($"Are there characters with no alias in the Donkey Kong series: {noAliasDk}");
//how many characters have no alias in the Donkey Kong series?
// int noAliasCountDk = characters.Count(c => c.Series.Contains("Donkey Kong") && c.Alias.Count() == 0);
// Console.WriteLine($"There are {noAliasCountDk} characters with no alias in the Donkey Kong series");
// List the characters that have no alias in the Donkey Kong series - return the name and alias only
// foreach(CharacterDTO characterDTO in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Alias.Count() == 0).Select(c => new CharacterDTO{ Name = c.Name, Alias = c.Alias }))
// {
//   Console.WriteLine($"{characterDTO.Name} - {string.Join(", ", characterDTO.Alias)}");
// }
//Do any characters have an alias of Snowmad King?
// bool snowmadKing = characters.Any(c => c.Alias.Contains("Snowmad King"));
// Console.WriteLine($"Are there characters with the alias Snowmad King: {snowmadKing}");
//List the characters that have an alias of Snowmad King - return the name and alias only
// foreach(CharacterDTO characterDTO in characters.Where(c => c.Alias.Contains("Snowmad King")).Select(c => new CharacterDTO{ Name = c.Name, Alias = c.Alias }))
// {
//   Console.WriteLine($"{characterDTO.Name} - {string.Join(", ", characterDTO.Alias)}");
// }
// do any characters have an alias of Winter Kong?
bool winterKong = characters.Any(c => c.Alias.Contains("Winter Kong"));
Console.WriteLine($"Are there characters with the alias Winter Kong: {winterKong}");

