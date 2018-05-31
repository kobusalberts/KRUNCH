# KRUNCH
PROBLEM ONE: KRUNCH
A krunched word has no vowels (&quot;A&quot;, &quot;E&quot;, &quot;I&quot;, &quot;O&quot;, and &quot;U&quot;) and no repeated letters. 

Removing
vowels and letters that appear twice or more from MISSISSIPPI yields MSP.
In a krunched word, a
letter appears only once, the first time it would appear in the unkrunched word. Vowels never
appear.

Krunched phrases similarly have no vowels and no repeated letters. Consider this phrase:
RAILROAD CROSSING
and its krunched version:
RLD CSNG

Blanks are krunched differently. Blanks are removed so that a krunched phrase has no blanks on its
beginning or end, never has two blanks in a row, and has no blanks before punctuation. Otherwise,
blanks are not removed. If we represent blanks by &quot;_&quot;,
MADAM_I_SAY_I_AM_ADAM__

krunches to:
MD_SY

where the single remaining blank is shown by &quot;_&quot;.

Write a program that reads a line of input (whose length ranges from 2 to 70 characters), and
krunches it. Put the krunched word or phrase in the output file. The input line has only capital
letters, blanks, and the standard punctuation marks: period, comma, and question mark.
SAMPLE INPUT:

NOW IS THE

TIME FOR ALL GOOD MEN TO COME TO THE AID OF THEIR
COUNTRY.
SAMPLE OUTPUT:

NW S TH M FR L GD C Y.
