# Guided Assignment: Implementing and Understanding Merge Sort in C#

## Introduction
In this guided assignment, you will delve into one of the most efficient sorting algorithms used in computer science: Merge Sort. This algorithm is a perfect example of a divide and conquer strategy. You will implement Merge Sort in C#, understand its working mechanism, and analyze its efficiency.

---

## How Does A Merge Sort Work?

Merge Sort is a popular sorting algorithm that uses the Divide and Conquer approach to sort a list of elements. It breaks down the sorting problem into smaller subproblems, solves them, and then combines the results to get the sorted list. Here's a pseudocode representation of the Merge Sort algorithm, along with an explanation of its purpose and the concept of Divide and Conquer:

### ***Psuedocode Explination:***
https://www.youtube.com/watch?v=aJVMJrgOPYc

**Merge Sort Pseudocode:**
```python
function mergeSort(arr)
    if length(arr) <= 1:
        return arr
    
    middle = length(arr) // 2
    left_half = arr[:middle]
    right_half = arr[middle:]
    
    left_half = mergeSort(left_half)
    right_half = mergeSort(right_half)
    
    return merge(left_half, right_half)

function merge(left, right)
    result = []
    left_index, right_index = 0, 0
    
    while left_index < length(left) and right_index < length(right):
        if left[left_index] < right[right_index]:
            result.append(left[left_index])
            left_index++
        else:
            result.append(right[right_index])
            right_index++
    
    result.extend(left[left_index:])
    result.extend(right[right_index:])
    return result
```

**Purpose of Merge Sort:**
The primary purpose of Merge Sort is to sort a list of elements in ascending (or descending) order. It does this efficiently by recursively dividing the input list into smaller halves, sorting those halves, and then merging them back together in a sorted manner. Merge Sort is known for its stable sorting property, meaning that it maintains the relative order of equal elements.

**Divide and Conquer:**
Merge Sort is a classic example of the Divide and Conquer algorithmic paradigm. Divide and Conquer involves breaking down a problem into smaller, more manageable subproblems, solving each subproblem independently, and then combining the results of the subproblems to obtain the final solution. In the case of Merge Sort:

1. **Divide**: The original list is divided into two equal (or nearly equal) halves.
2. **Conquer**: Each of these halves is sorted using the Merge Sort algorithm recursively. This is the conquer phase.
3. **Combine**: Finally, the sorted halves are merged back together in a way that maintains their sorted order, resulting in a fully sorted list.

The Divide and Conquer approach is advantageous because it often leads to more efficient algorithms. By breaking down a problem into smaller pieces, you can solve them independently, potentially reducing the time complexity of the overall algorithm. Merge Sort's time complexity is O(n log n), which makes it efficient for sorting large lists of elements.

---

## Detailed Requirements

### COMMENTING YOUR CODE IS REQUIRED, EXPLAIN WHAT IS HAPPENING

### Project Setup (10 Points)
- Create a new console application in your IDE (e.g., Visual Studio).
- Name the project `MergeSortAssignment`.
- Ensure the project is properly set up with default files like `Program.cs`.

### Understanding Merge Sort (10 Points)
- Research and understand the Merge Sort algorithm.
- Write a brief explanation in the `Main` method comments about how Merge Sort works.

### Implementing Merge Sort (30 Points)
- Implement the Merge Sort algorithm in a method called `MergeSort`.
- The method should take an array of integers and sort it.
- Use proper commenting to explain each step of the algorithm.

### Implementing the Merge Function (20 Points)
- Implement a `Merge` function used in the Merge Sort algorithm.
- This function should merge two subarrays into a sorted array.
- Comment on how the merging of subarrays is achieved.

### Testing the Algorithm (15 Points)
- In the `Main` method, create an array of integers to be sorted.
- Call the `MergeSort` method with this array.
- Print the sorted array to the console to verify correct sorting.

### Analyzing Algorithm Complexity (10 Points)
- Discuss the time complexity of Merge Sort in the `Main` method comments.
- Explain why Merge Sort is more efficient compared to simpler sorting algorithms like Bubble Sort.

### Submission (5 Points)
- Successfully upload the complete project to a repository (e.g., GitHub).
- Ensure the repository is public and contains all necessary files.
- Submit the link to your GitHub repository.

#### Total (100 Points)
- Each section is crucial for understanding and implementing Merge Sort.

---



### ***Code Walkthrough:***
https://youtu.be/CKRkDt2Yud8?si=qow16xvSMDEop9h


### Starting Code
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Merge Sort Implementation in C#");
        // Array initialization and method calls will go here

               Console.WriteLine("Merge Sort Implementation in C#");

        int[] array = { 12, 11, 13, 5, 6, 7 };
        
        Console.WriteLine("Original Array:");
        PrintArray(array);

        MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("Sorted Array:");
        PrintArray(array);
    }

    // MergeSort method implementation will go here

    // Merge method implementation will go here
}
```

You'll start by implementing the Merge Sort method and the Merge function within this structure.

---

## Implementing Merge Sort

Merge Sort is a recursive algorithm that continually splits a list in half. If the list is empty or has one item, it is sorted by definition (the base case). If the list has more than one item, we split the list and recursively invoke a merge sort on both halves.

- Implement the `MergeSort` method in your program.

```csharp
public static void MergeSort(int[] array, int left, int right)
{
    if (left < right)
    {
        // Find the middle point
        int middle = (left + right) / 2;

        // Sort first and second halves
        MergeSort(array, left, middle);
        MergeSort(array, middle + 1, right);

        // Merge the sorted halves
        Merge(array, left, middle, right);
    }
}
```

---

## Implementing the Merge Function

The `Merge` function is used for merging two halves. The `Merge` function is key to understanding the Merge Sort algorithm.

- Implement the `Merge` function as part of the Merge Sort algorithm.

```csharp
public static void Merge(int[] array, int left, int middle, int right)
{
    // Implement the logic to merge two sorted subarrays into a single sorted array
    // Include comments explaining the merging process

            int n1 = middle - left + 1;
        int n2 = right - middle;

        // Create temporary arrays
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Copy data to temp arrays leftArray[] and rightArray[]
        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = array[middle + 1 + j];

        int k = left;
        int x = 0, y = 0;

        // Merge the temp arrays back into array[left..right]
        while (x < n1 && y < n2)
        {
            if (leftArray[x] <= rightArray[y])
            {
                array[k] = leftArray[x];
                x++;
            }
            else
            {
                array[k] = rightArray[y];
                y++;
            }
            k++;
        }

        // Copy the remaining elements of leftArray[], if there are any
        while (x < n1)
        {
            array[k] = leftArray[x];
            x++;
            k++;
        }

        // Copy the remaining elements of rightArray[], if there are any
        while (y < n2)
        {
            array[k] = rightArray[y];
            y++;
            k++;
        }
}
```


---

## Testing the Algorithm

- Create an integer array in the `Main` method.
- Call the `MergeSort` method and pass the array for sorting.
- Print the sorted array to validate the correctness of your implementation.

```csharp
    public static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

```

---

## Analyzing Algorithm Complexity

- In your `Main` method, include comments that discuss the time complexity of Merge Sort.
- Compare its efficiency with simpler algorithms and explain its advantages in the comments.

---

## Final Code

- Build your entire merge sort by hand, don't just fork the repo.
- Test your code with your own array of data.
- Comment ALL of your code.

---

## Rubric

| Criteria | Description | Points |
|----------|-------------|--------|
| **Project Setup** | Correct setup and naming of the console application. | 10 |
| **Understanding Merge Sort** | Accurate explanation of the Merge Sort algorithm. | 10 |
| **Implementing Merge Sort** | Proper implementation of the Merge Sort method. | 30 |
| **Implementing the Merge Function** | Correct implementation of the Merge function. | 20 |
| **Testing the Algorithm** | Successful testing and validation of the algorithm. | 15 |
| **Analyzing Algorithm Complexity** | Insightful discussion of the algorithm's time complexity. | 10 |
| **Submission** | Successful upload to GitHub with all necessary files. | 5 |
| **Total** |

  | 100 |

OpenAI. (2024). Implementing and Understanding Merge Sort in C#. ChatGPT Guided Assignment.