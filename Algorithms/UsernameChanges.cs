public class UsernameChanges
{
    public static List<string> possibleChanges(List<string> usernames)
    {
        List<string> results = new List<string>();

        foreach (string username in usernames)
        {
            results.Add(CanBeSmaller(username));
        }

        return results;
    }

    // Harflerin yer değiştirilmesiyle alfabetik olarak daha küçük bir isim elde edilip edilmeyeceğini kontrol eden optimize edilmiş fonksiyon
    private static string CanBeSmaller(string name)
    {
        // İsmin soldan sağa büyükten küçüğe doğru bir yer varsa "Evet" döndür
        for (int i = 0; i < name.Length - 1; i++)
        {
            if (name[i] > name[i + 1])
            {
                return "Evet";
            }
        }

        return "Hayır";
    }
}