# Sentry
A system to watch and display log messsages.

This project was inspired by https://sentinel.codeplex.com/

Unfortunately when looking at sentinel source it didn't appear to be developed using TDD.

So the purpose of Sentry is to build a log monitoring and analysis system using TDD and at the same time use this a a teaching resource.

# Basic Idea (4/1/17).

The sentry conssts of a Hub.

Listeners can be registered with the hub.

Listeners can be unregistered from the hub.

A listerner raises events on the IListener interface.

NOTE: The initial version of these notes will use MSTest as this is in use where the notes will be used.

In this first part we want to make sure there is only one instance of each listener added so that we don't get duplicate log messages.

# Testing Exceptions First (10/1/17)

Following Bob Martin, he suggests that exceptions shold be tested first:

https://www.safaribooksonline.com/a/clean-code/4800608/