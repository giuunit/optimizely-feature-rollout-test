# optimizely-feature-rollout-test

Test application to enable Optimizely Feature Rollout capabilities to deploy a Messenger Chat plugin on a website. 

The template is a standard ASP.NET MVC application using .net Framework 4.8 

## What is the goal of the application ?

This application is an example of project using Optimizely to rollout a feature for a web project. 

I picked the **Facebook Messenger Chat Plugin** as it is valuable for businesses to enable chat / customer support abilities for their website and 
this project highlights the steps to enable the plugin using Optimizely Rollout capabilities.

**Disclaimer**

The code available below is for demonstration purposes. It is not production-ready. 

## How to run the project ? 

### Setting up the Messenger Chat Plugin

1. Create a facebook page (the one I created is called 'Optimizely Feature Rollout Test' : https://www.facebook.com/Optimizely-Feature-Rollout-Test-106580551589279 )
2. Go to Page Settings > Messaging & In the 'Add Messenger to your website' section, click the 'Get Started' Button to set up the plugin.
3. Add the following url to the list of urls that are enabled for the plugin: http://local.rollout-test.com

### Setting up the Optimizely Feature Flag

4. sign up for a free account here: https://www.optimizely.com/uk/rollouts/
5. create a feature flag called 'enable_messenger_chat', enable it for Development
6. set a variable page_id with the id of the facebook page that was created earlier.

### Setting up the test project

7. Clone the repository.
8. Create a local website using IIS and set the path to the \OptimizelyFeatureRolloutTest folder (the one containing the web.config) and add local.rollout-test.com as url for the website.
9. Update your hosts file with the following line: 127.0.0.1	local.rollout-test.com
10. Update the web.config file and set the value for the **Optimizely:sdkKey** setting with the sdk Key that you retrieved when signing up to Optimizely.

### Testing the rollout

10. Rebuild your solution and go to http://local.rollout-test.com without enabling the feature. The website should load without the plugin. 
11. Enable the feature using Optimizely backoffice, refresh your page and the plugin should now be available. 

**Notes**

- Steps 8 & 9 are mandatory as the messenger web plugin requires a proper url & doesn't accept 'localhost' as url.
- For the sake of this tutorial, we didn't enable production rollout. It is possible to do it as well using transform files and a separate sdk key.