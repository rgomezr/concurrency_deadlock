![.NET Build](https://github.com/rgomezr/concurrency_deadlock/actions/workflows/dotnet_build.yml/badge.svg)

# Concurrency_deadlock
Making deadlock scenarios within sync and async setups.

# 🎯 Objective

The main objective of this repo is not really deadlocks and the different ways of avoiding them (:trollface:), but, the use of different DevOps practises, such as CI/CD implementations.

* Approach a deadlock situation with async and sync solutions.
* Containerise with Docker this .NET Core 6 app.
* Apply various branch protection rules to test them out.
* Set up different Github Actions towards a good CI/CD environment. Some of them are (will be applied on each PR creation):
  * Build.
  * Security scan for vulnerabilities.
  * Testing source code.
* Use tags & releases together with the creation of a package.
