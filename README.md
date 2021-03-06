# Message-Box
Message box for C# .NET Framework (windows form)

# How to use

You must add this dll to your project before using it.

πFirst go to the solution explorer on the right side and right click on the references under your project.

πThen select add references and then click on the browse button, select dll file and click on the ok button.

as follows

![ezgif com-gif-maker (1)](https://user-images.githubusercontent.com/80079235/135741176-4262c2ac-5015-4506-81bc-76ad4ea2bcc0.gif)

πThen you need to import this code segment

    using SMDMessageBox;

as follows

![Screenshot_13](https://user-images.githubusercontent.com/80079235/135741082-d23f942f-8c83-4d37-a950-4faf569d57bf.png)

Then you can use it like default windows form messagebox using as follows examples

 # π INFORMATION MESSAGE

    SMDMessage.show("Title", "Message", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
    
   ![ezgif com-gif-maker (2)](https://user-images.githubusercontent.com/80079235/135741384-782037b5-9189-41fe-bf96-d3c422bc9dac.gif)
   

 # π ERROR MESSAGE

    SMDMessage.show("Title", "Message", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
  
   ![ezgif com-gif-maker (3)](https://user-images.githubusercontent.com/80079235/135741463-10b55d99-ea29-4742-978b-9ab0299f1ccb.gif)
   
  
   # π WARNING MESSAGE

    SMDMessage.show("Title", "Message", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Warning);
    
   ![ezgif com-gif-maker (4)](https://user-images.githubusercontent.com/80079235/135741569-628e4ac4-b092-4b59-914c-ba2732db2f92.gif)
   

   # π QUESTION MESSAGE

    SMDMessage.show("Title", "Message", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Question);
    
   ![ezgif com-gif-maker (5)](https://user-images.githubusercontent.com/80079235/135741688-8f87e626-2ccc-4ee7-a14e-dcfe6d2ce33d.gif)

Here you can see the Buttons type as in the default C# message box.

![Screenshot_14](https://user-images.githubusercontent.com/80079235/135741792-d7a2437a-55b0-4b6c-9206-6b19eefd2f77.png)
