// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

string awsAccessKeyId = "AKIAIOSFODNN7EXAMPLE"; // Example AWS Access Key ID
string awsSecretAccessKey = "wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY"; // Example AWS Secret Access Key

Console.WriteLine("Attempting to use the following AWS credentials:");
Console.WriteLine($"AWS Access Key ID: {awsAccessKeyId}");
Console.WriteLine($"AWS Secret Access Key: {awsSecretAccessKey}");

// Simulate using the AWS credentials
UseAwsCredentials(awsAccessKeyId, awsSecretAccessKey);

void UseAwsCredentials(string awsAccessKeyId, string awsSecretAccessKey)
{
            // Dummy method to simulate using AWS credentials
            Console.WriteLine("Using AWS credentials...");
}