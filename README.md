# All Global Usings Generator

This source generator will generate a file that contains a `global using` statement for every namespace in your compilation that has a type in it that isn't defined in source. ie, one for every possible namespace in all of your dependencies.

I do not recommend using this. It's a silly idea IMO. I just wrote it because I was nerd sniped/nerd sniped myself after reading Nick's tweet: https://twitter.com/thenickrandolph/status/1503999593964785665