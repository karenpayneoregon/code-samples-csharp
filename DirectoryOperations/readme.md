# About

Code in this project shows operations done correctly and incorrectly although in some cases the incorrect opteration may be find for a task while in later task may run into runtime exceptions.

For example, recursively removing an entire folder structure.

* **Case one**, remove a folder structure under the users Document folder, unless an item is in use a simple method is fine.
* **Case two**, remove a folder structyre under a protected folder structure by Windows permissions, the simple method without proper assertion and/or use of a try-catch statement can lead to a runtime exception being thrown.