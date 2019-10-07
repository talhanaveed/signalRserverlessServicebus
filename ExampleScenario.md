---
title: Sharing location in real time using low cost serverless Azure services
description: SignalR configured in server-less mode to work with Azure Function triggered by Service Bus. All of it using .NET Core. This scenario is best used for real time messaging applications where users require a low-cost but robust messaging service. 
author: talhanaveed
ms.date: 10/10/2019
---
# Sharing location in real time using low cost serverless Azure services

Ever wondered how you receive location of your Uber without the whole page refreshing? How you are able to track your food delivery guy in real time? How social media services are able to send you notifications without a browser refresh? Real time messaging services. That's how!

In this example, I look at how we can set up a real time messaging service to share live location of a food delivery guy on his way to deliver to you a fresh pizza. This example can also be useful for users trying to build a real time location sharing platform for their web or mobile applications.

Azure allows you to go server-less and only pay for what you use. So if your clients have budget issues and cannot afford servers for hosting your messaging service backend, this example is for you!

I will be using a SignalR service configured in server-less mode to integrate with an Azure Functions app triggered by a Service Bus. All of it using .NET Core

## Potential use cases

> Are there any other use cases or industries where this would be a fit?
> How similar or different are they to what's in this article?

These other uses cases have similar design patterns:

* List of example use cases

## Architecture

*Architecture Diagram goes here*

> What does the solution look like at a high level?
> Why did we build the solution this way?
> What will the customer need to bring to this?  (Software, skills, etc?)
> Is there a data flow that should be described?

### Components

A bullet list of components in the architecture (including all relevant Azure services) with links to the product documentation.

> Why is each component there?
> What does it do and why was it necessary?

* Example: [Resource Groups][resource-groups] is a logical container for Azure resources.  We use resource groups to organize everything related to this project in the Azure console.

### Alternatives

Use this section to talk about alternative Azure services or architectures that you might consider for this solution. Include the reasons why you might choose these alternatives.

> What alternative technologies were considered and why didn't we use them?

## Considerations

> Are there any lessons learned from running this that would be helpful for new customers?  What went wrong when building it out?  What went right?

### Availability, Scalability, and Security

> How do I need to think about managing, maintaining, and monitoring this long term?

> Are there any size considerations around this specific solution?
> What scale does this work at?
> At what point do things break or not make sense for this architecture?

> Are there any security considerations (past the typical) that I should know about this?

## Deploy this scenario

> (Optional if it doesn't make sense)
>
> Is there an example deployment that can show me this in action?  What would I need to change to run this in production?

## Pricing

> How much will this cost to run?
> Are there ways I could save cost?
> If it scales linearly, than we should break it down by cost/unit.  If it does not, why?
> What are the components that make up the cost?
> How does scale effect the cost?
>
> Link to the pricing calculator with all of the components in the architecture included, even if they're a $0 or $1 usage.
> If it makes sense, include a small/medium/large configurations.  Describe what needs to be changed as you move to larger sizes

## Next Steps

> Where should I go next if I want to start building this?
> Are there any reference architectures that help me build this?

## Related Resources

> Are there any relevant case studies or customers doing something similar?
> Is there any other documentation that might be useful?
> Are there product documents that go into more detail on specific technologies not already linked

<!-- links -->
[calculator]: https://azure.com/e/
[availability]: /azure/architecture/checklist/availability
[resource-groups]: /azure/azure-resource-manager/resource-group-overview
[resiliency]: /azure/architecture/resiliency/
[security]: /azure/security/
[scalability]: /azure/architecture/checklist/scalability
