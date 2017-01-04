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

NOTE: The initial version of these notes will use MSTest as thisis in use where the notes will be used.