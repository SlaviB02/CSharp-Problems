IList<IList<int>> PalindromePairs(string[] words)
{
    IList<IList<int>> pairs = new List<IList<int>>();
    for (int i = 0; i < words.Length; i++)
    {
        for (int j = i + 1; j < words.Length; j++)
        {
            string word1 = words[i] + words[j];
            string word2 = words[j] + words[i];
            char[] letters1 = word1.ToCharArray();
            Array.Reverse(letters1);
            string reversed1 = new string(letters1);
            char[] letterrs2 = word2.ToCharArray();
            Array.Reverse(letterrs2);
            string reversed2 = new string(letterrs2);
            if (word1 == reversed1)
            {
                pairs.Add(new List<int>() { i, j });
            }
            if (word2 == reversed2)
            {
                pairs.Add(new List<int>() { j, i });
            }
        }
    }

    return pairs;
}