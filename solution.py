def is_rotation(s1: str, s2: str) -> bool:
    if len(s1) != len(s2):
        return False
    return s1 in s2 + s2

def main():
    s1 = input("Enter the first string: ")
    s2 = input("Enter the second string: ")
    if is_rotation(s1, s2):
        print(f"{s2} is a rotation of {s1}")
    else:
        print(f"{s2} is not a rotation of {s1}")

if __name__ == "__main__":
    main()