---
layout: post
title:  "First post!"
date:   2024-02-10 16:06:00 -0800
categories: updates
---

Trying out this GitHub Pages thing to showcase my ideas and projects for myself and everyone else who happens to stumble upon this site.

This seems kind of interesting so far!

It's taken me about an hour to figure out how to change the font to the code blocks, so that's fun. As you can tell I'm very proficient in front-end development.

To celebrate my struggles, I've thrown in a random leetcode problem solution so I can check out the code block!

{% highlight csharp %}
public static bool CanPlaceFlowers(int[] flowerbed, int n) {
    int flowersPlaced = 0;

    int i = 0;
    while (i < flowerbed.Length && flowersPlaced < n) {

        // If the current position is a flower, move 2 spaces and continue
        if (flowerbed[i] == 1) {
            i += 2;
            continue;
        }

        // If the current spot is a 0, check 1 place to left and right to see those are also 0
        if (i > 0 && flowerbed[i - 1] == 1) {
            i++;
            continue;
        } else if (i < flowerbed.Length - 1 && flowerbed[i + 1] == 1) {
            i += 3;
            continue;
        }

        // If both sides are clear to place a flower, place a flower
        flowerbed[i] = 1;
        flowersPlaced++;
        i += 2;
    }

    return flowersPlaced == n;
}
{% endhighlight %}