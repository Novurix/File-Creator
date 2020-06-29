def create_file(file_name):
    # creates / modifies file

    file = open(file_name,"w+")
    file.write("hello world")
    file.flush()
    file.close()

create_file("file_name.txt")
