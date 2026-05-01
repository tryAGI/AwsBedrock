<div class="docs-hero">
  <h1>AwsBedrock</h1>
  <p class="docs-hero-lead">Modern .NET SDK for Amazon Bedrock OpenAI-compatible APIs, generated with AutoSDK from a hand-maintained OpenAPI definition.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/AwsBedrock/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/AwsBedrock"></a>
    <a href="https://github.com/tryAGI/AwsBedrock/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/AwsBedrock/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/AwsBedrock/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/AwsBedrock"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from provider docs</h3>
    <p>Built from a hand-maintained OpenAPI file based on <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/bedrock-mantle.html">Amazon Bedrock OpenAI-compatible API docs</a>.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using AwsBedrock;

using var client = new AwsBedrockClient(apiKey);
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/AwsBedrock/issues">tryAGI/AwsBedrock</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/AwsBedrock/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
