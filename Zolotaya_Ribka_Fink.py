num_word = int(input())
words = []

for i in range(num_word):
    words.append(input())
    
num_start = int(input())
starts = {}

for i in range(num_start):
    a = input().split()
    starts[a[0]] = int(a[1])
    
num_end =  int(input())
ends = {}

for i in range(num_end):
    a = input().split()
    ends[a[0]] = int(a[1])
    
otvet = []
    
for i in words:
    print(i[0], i[len(i) - 1])
    for j in starts.keys():
        if starts[j] != 0:
            for k in ends.keys():
                if ends[k] != 0:
                    if i[0] == j and i[len(i) - 1] == k:
                        otvet.append(i)
                        starts[j] = starts[j] - 1
                        ends[k] = ends[k] - 1
                    else:
                        continue
                else:
                    continue
        else:
            continue
print(len(otvet))
