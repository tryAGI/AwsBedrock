#!/usr/bin/env bash
set -euo pipefail

# Hand-maintained OpenAPI spec based on:
# https://docs.aws.amazon.com/bedrock/latest/userguide/bedrock-mantle.html

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace AwsBedrock \
  --clientClassName AwsBedrockClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
