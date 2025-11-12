# Task 1.
You need to create a system to generate system logs. It is known that the average size of a log entry is about 200 characters, and 50 entries need to be processed.
# Required actions:
- Create a StringBuilder with an initial capacity of 10,000 characters (calculated for 50 entries × 200 characters)
- Gradually add 5 log entries of different contents to it
- Replace the word "Error" with "Warning" in all entries.
- Add 3 more entries after replacement
- Finally, reduce the capacity of the StringBuilder to the actual size used
  Log example:
  [2024-01-15 10:00:00] System started
  [2024-01-15 10:01:23] Error: Failed to connect to database
  [2024-01-15 10:06:45] Security check...

# Task 2.
Implement a method to encrypt/decrypt a string by shifting letters by N positions. Use an alphabet array and a StringBuilder to build the result.
