#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# Hand-maintained OpenAPI spec based on:
# https://docs.aws.amazon.com/bedrock/latest/userguide/bedrock-mantle.html
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace AwsBedrock \
  --clientClassName AwsBedrockClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
