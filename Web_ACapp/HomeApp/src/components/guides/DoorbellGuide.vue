<script setup>
import { computed, ref } from "vue";
import { RouterLink, RouterView } from "vue-router";

import markdownit from "markdown-it";

const md = markdownit();

const result = md.render(`


# Video Doorbell Guide

   Video doorbells serve as modern, multifunctional security devices that enhance   home safety and convenience. These devices, typically installed near the entrance of a home, offer real-time video and audio surveillance, allowing homeowners to remotely monitor and interact with visitors through a connected smartphone or tablet. Video doorbells serve as a deterrent to potential intruders, providing a sense of security by capturing motion-triggered footage and sending instant alerts. Beyond security, they facilitate seamless communication with delivery personnel, guests, or neighbors, enabling users to remotely grant access, receive package notifications, and even engage in two-way conversations. With features like night vision, wide-angle lenses, and cloud storage, video doorbells have become integral components of smart home ecosystems, offering a comprehensive solution for both monitoring and managing access to the home.

## Things to Consider 


 1.	Compatibility
 -	Check compatibility with existing doorbell wiring.
 -	Verify integration with smart home platforms.

 2.	Wi-Fi
 -	Ensure stable Wi-Fi connection at installation location.

 3.	Power
 -	Determine battery or wired power source preference.
 -	Wired video doorbells will require a Wired 16VAC/30VA Doorbell Transformer.

 4.	Field of View
 -	Check camera's field of view for desired coverage.

 5.	Resolution & Night Vision
 -	Review video doorbell's resolution and quality.
 -	Verify night vision capabilities for low-light conditions.



## Wired Doorbell Installation Steps: 

### Materials for Installation: 
- Video doorbell kit
- Screwdriver
- Drill (if necessary)
- Voltage tester
- Smartphone or tablet for setup


###  Check Existing Transformer: 

1.  Locate the Transformer: 
  - Identify the location of your existing doorbell transformer. It is typically mounted near the electrical panel or in the vicinity of your doorbell chime.

2.  Read Transformer Label: 
  - Examine the label on the transformer. Look for information on voltage and power rating. A standard video doorbell usually requires 16-24 volts AC.

3.  Check Compatibility: 
   - Verify that the existing transformer is compatible with the voltage requirements of your video doorbell. If it falls within the specified range, it may be suitable.
   - If it doesn't fall within the range, refer to swapping doorbell transformer.

4. Turn Off Power: 
  - Locate and turn off the power to your existing doorbell at the breaker box to ensure safety during installation.

5.  Remove Old Doorbell: 
   - If you have an existing doorbell, carefully remove it by unscrewing it from the wall and disconnecting the wires.

6.  Check Voltage: 
   - Use a voltage tester to ensure that the power is off. Test the wires coming out of the wall to make sure there is no electrical current.

7.  Mount the Bracket: 
   - Attach the mounting bracket that comes with the video doorbell to the wall. Use screws to secure it in place. Some doorbells come with a backplate; make sure to follow the manufacturer's instructions.

8.  Connect Wires: 
   - Connect the wires from your home to the corresponding terminals on the back of the video doorbell. Follow the color-coding or labeling provided in the instructions. Tighten the screws to secure the connections.

9.  Attach Doorbell: 
   - Secure the video doorbell to the mounting bracket. It may snap into place or require additional screws, depending on the model.

10. Adjust Position: 
   - Adjust the position of the video doorbell to ensure it captures the desired field of view. Most doorbells allow you to tilt and swivel the camera for optimal positioning.

11. Secure Additional Components: 
   - If your doorbell comes with additional components such as a chime or a power kit, follow the manufacturer's instructions to install and secure them.

12.  Power On: 
   - Turn the power back on at the breaker box.

13.  Setup and Testing: 
 - Download the associated app for your video doorbell on your smartphone or tablet. Follow the in-app instructions to set up the device, connect it to your Wi-Fi network, and customize settings. Test the doorbell to ensure it's functioning correctly.

14.  Secure the Video Doorbell: 
 - Ensure that all components are securely attached and that the video doorbell is properly sealed against the elements. Some models may include security screws to prevent tampering.

Remember to consult the specific installation instructions provided by the manufacturer of your video doorbell, as different models may have unique requirements and features. If you are unsure about any step, it's always a good idea to seek professional assistance.
Determining if you have the correct doorbell transformer for video doorbells and swapping it out involves several steps. Here's a guide to help you through the process:




###  Swapping Doorbell Transformer: 

1.  Purchase a Compatible Transformer: 
   - If your existing transformer is not compatible, purchase a new one that meets the voltage requirements of your video doorbell. Common voltage ratings are 16V or 24V AC.

2.  Turn Off Power: 
   - Turn off the power at the breaker box before attempting to replace the transformer.

3.  Disconnect Existing Transformer: 
   - Carefully disconnect the wires connected to the existing transformer. Note the wire colors and their respective terminals.

4.  Remove Old Transformer: 
   - Unscrew and remove the old transformer from its mounting location.

5.  Mount New Transformer: 
   - Mount the new transformer in the same location using the provided screws. Ensure that it is securely attached.

6.  Connect Wires: 
   - Connect the wires from your home to the corresponding terminals on the new transformer. Follow the color-coding or labeling provided in the instructions.

7.  Turn On Power: 
   - Turn the power back on at the breaker box.

8.  Test Voltage: 
   - Use a multimeter to test the voltage across the wires connected to the new transformer. Confirm that the reading falls within the recommended range for your video doorbell.

9.  Install Video Doorbell: 
   - Once the new transformer is in place, you can proceed with installing or connecting your video doorbell following the manufacturer's instructions.

Always refer to the specific instructions provided by the manufacturer of your video doorbell and the replacement transformer. If you are unsure or uncomfortable with electrical work, it is advisable to seek professional assistance to ensure a safe and proper installation.

https://www.homedepot.com/p/Defiant-Wired-16VAC-30VA-Doorbell-Transformer-Compatible-with-all-Video-Doorbells-18000044/322882044

`);
</script>
<template>
  <div v-html="result"></div>
</template>
