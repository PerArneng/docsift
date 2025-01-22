# Makefile for DocSift

.PHONY: build
build: ## Build the solution.
	dotnet build

.PHONY: run
run: ## Run the CLI application.
	dotnet run --project DocSift.Cli

.PHONY: test
test: ## Run the tests (if a test project exists).
	dotnet test

.PHONY: clean
clean: ## Clean the build artifacts.
	dotnet clean

.PHONY: restore
restore: ## Restore dependencies for the solution.
	dotnet restore

.PHONY: format
format: ## Format the code using dotnet format.
	dotnet format

.PHONY: lint
lint: ## Check for style and code quality issues.
	dotnet format --verify-no-changes

.PHONY: publish
publish: ## Publish the CLI app (ready for deployment).
	dotnet publish DocSift.Cli -c Release -o publish/

.PHONY: help
help: ## Display this help message.
	@sh .make/makefile-help.sh $(MAKEFILE_LIST)
