
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
<<<<<<< HEAD

        if(numbers == "")
        {
            return 0;
        }
        if (numbers.Contains('\n'))
        {
            var sum = numbers
                .Split(new[] { ',' , '\n'})
                .Select(x => int.Parse(x.Trim()))
                .Sum();
            return sum;
        }
        if (numbers.Contains(','))
        {
            var sum = numbers
                .Split(new[] {','})
                .Select(x => int.Parse(x.Trim()))
                .Sum();
            return sum;
        }
        return int.Parse(numbers);
=======
        var delimeters = new List<char> { ',', '\n' };
        if (numbers.StartsWith("//"))
        {
            // "1*3"
            delimeters.Add(numbers[2]);
            numbers = numbers.Substring(4);
        }
        return numbers == "" ? 0 :numbers.Split(delimeters.ToArray()).Select(int.Parse).Sum();

>>>>>>> 5e1b4612c6e321c79c575e398cc0bfe770e4d381
    }
}
