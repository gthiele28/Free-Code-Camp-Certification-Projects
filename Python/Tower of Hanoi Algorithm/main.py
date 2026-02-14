def hanoi_solver(n):
    source = list(range(n, 0, -1))
    auxiliary = []
    target = []
    
    moves = []

    def record_state():
        moves.append(f"{source} {auxiliary} {target}")

    def solve(num_disks, from_rod, to_rod, aux_rod):
        if num_disks == 1:
            to_rod.append(from_rod.pop())
            record_state()
        else:
            solve(num_disks - 1, from_rod, aux_rod, to_rod)
            to_rod.append(from_rod.pop())
            record_state()
            solve(num_disks - 1, aux_rod, to_rod, from_rod)

    record_state()

    solve(n, source, target, auxiliary)
    
    return "\n".join(moves)