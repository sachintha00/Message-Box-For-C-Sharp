# Message-Box
Message box for C# .NET Framework (windows form)

# How to use

You must add this dll to your project before using it.

👉First go to the solution explorer on the right side and right click on the references under your project.

👉Then select add references and then click on the browse button, select dll file and click on the ok button.

as follows

![ezgif com-gif-maker (1)](https://user-images.githubusercontent.com/80079235/135741176-4262c2ac-5015-4506-81bc-76ad4ea2bcc0.gif)

👉Then you need to import this code segment

    using SMDMessageBox;

as follows

![Screenshot_13](https://user-images.githubusercontent.com/80079235/135741082-d23f942f-8c83-4d37-a950-4faf569d57bf.png)

Then you can use it like default windows form messagebox using as follows examples

 # INFORMATION MESSAGE

    SMDMessage.show("Title", "Message", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Information);
    
![ezgif com-gif-maker (2)](https://user-images.githubusercontent.com/80079235/135741384-782037b5-9189-41fe-bf96-d3c422bc9dac.gif)

 # ERROR MESSAGE

    SMDMessage.show("Title", "Message", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
  
  ![ezgif com-gif-maker (3)](https://user-images.githubusercontent.com/80079235/135741463-10b55d99-ea29-4742-978b-9ab0299f1ccb.gif)
