# About 

This project shows how to create an SQL SELECT WHERE IN statement for strings and int. Currently the backend code supports Microsoft SQL-Server while for other databases needs modification as per comments in SqlGenerator.CreateWhereStatement().

An easier way might be to use string concatenation while in this case one must 
consider apostrophes when dealing with strings e.g. Daniel O<kbd>'</kbd>Neal with string concatenation and no concern for apostrophes will be a problem at runtime and an exception will be thrown. 

![screen](../assets/SqlBuilder.png)
