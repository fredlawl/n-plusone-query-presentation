# Pesky n + 1 Queries and how to fix them

## Abstract

Interacting with a database can be a frustrating experience for developers
that are unfamiliar with the concepts involved. Most notably, query writing
may be simplified via the use of Object Relational Mapping (ORM) tools or
other tooling to abstract the nitty-gritties away from the developer.
Without a fundamental understanding of how Structured Query Language (SQL)
interfaces with databases behind the scenes, developers are prone to
inevitably write the dreaded n + 1 query. We've all written them whether we
knew it or not.

n + 1 queries are notorious for being a main cause of poor performance within
an application, and at the same time, are not super trivial to fix or notice
through the lenses of code abstractions.

This topic is a exploration into what common problems and solutions lead to
developers writing n + 1 queries, how to detect them, and how to fix them.
We'll be looking into embedded SQL solutions as well as ORM solutions for the
MySQL Database Management System (DBMS). Code will be presented using
.NET Core C#, and the Entity Framework ORM; however, the concepts transcend
language and DBMS boundaries.

Code, slides, and toy-database dump can be found at:

[github/fredlawl](https://github.com/fredlawl/n-plusone-query-presentation)


## Intended Audience

The intended audience is for those who are interested in a cheap and
effective way to improve application performance through minimizing the
amount of read-only queries performed on larger data-sets. The audience
should be familiar with using a database for SELECT operations. Previous
knowledge of the n + 1 query problem is not mandatory. Those who are
familiar with the problem may benefit from spotting techniques, and the
solutions to solve this problem.
