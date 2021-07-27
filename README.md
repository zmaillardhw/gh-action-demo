[![Deploy](https://github.com/zmaillardhw/gh-action-demo/actions/workflows/deploy.yaml/badge.svg)](https://github.com/zmaillardhw/gh-action-demo/actions/workflows/deploy.yaml)

# GitHub Action - Demo

Two GitHub Actions [Build](.github/workflows/build.yaml) and [Deploy](.github/workflows/deploy.yaml).


#### Build Pipeline
The build pipeline listens on all Pull Request events and runs the following steps:

- Checkout Code
- Configure .NET Environment
- Build (`dotnet build`)
- Test (`dotnet test`) and generate coverage reports (using [Coverlet](https://dotnetfoundation.org/projects/coverlet) library installed in .NET Test Project)
- Display Test Coverage Results (using [zgosalvez/github-actions-report-lcov@v1](https://github.com/zgosalvez/github-actions-report-lcov))
- Fail Pipeline If Test Coverage Is Under Threshold of 70% (Defined as Environment variable (`MIN_TEST_COVERAGE_PCT: 70`) in Action)

#### Deploy Pipeline
The deploy pipeline listens on all pushes to the `main` branch.

- Checkout Code
- Generate New Version Number and New Git Tag using [anothrNick/github-tag-action](https://github.com/anothrNick/github-tag-action)

- For each Deployment Environment (dev, test, prod) do the following:
  - Configure .NET Environment
  - Build (`dotnet build`) and set version number in assembly.
  - Test (`dotnet test`) 

- For prod deploy, an extra manual approval is needed.  Configured in the `prod` environment in the [GitHub Repository Settings](https://github.com/zmaillardhw/gh-action-demo/settings/environments/275540830).
